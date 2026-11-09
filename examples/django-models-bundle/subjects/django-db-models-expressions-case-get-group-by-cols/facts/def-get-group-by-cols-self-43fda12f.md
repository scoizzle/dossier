# Fact 43fda12f

Store id: fbe228da-2181-42e7-8439-58e5bedd5cf7

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
- posted_at: `2026-11-09T23:44:49.6312000+00:00`

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
  "id": "fbe228da-2181-42e7-8439-58e5bedd5cf7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6312000+00:00"
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
  "subject_id": "eae1c699-af3f-4ece-bb86-a5f96ae98a1d",
  "subject_name": "django/db/models/expressions::Case.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
