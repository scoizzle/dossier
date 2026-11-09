# Fact 43fda12f

Store id: b8f6988c-3a77-42e7-b9ad-45da1e1ede5c

## Text

```text
def get_group_by_cols(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.9646030+00:00`

## Data

```json
{
  "end_line": 1807,
  "entity_kind": "method",
  "parent": "Case",
  "start_line": 1804,
  "symbol": "Case.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1804,"selector":"L1804-L1807","symbol":"Case.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Case.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1807,
    "entity_kind": "method",
    "parent": "Case",
    "start_line": 1804,
    "symbol": "Case.get_group_by_cols"
  },
  "id": "b8f6988c-3a77-42e7-b9ad-45da1e1ede5c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9646030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1804,
        "selector": "L1804-L1807",
        "symbol": "Case.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "0df2c811-8346-4eee-b02f-cf065b42ce56",
  "subject_name": "django/db/models/expressions::Case.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
