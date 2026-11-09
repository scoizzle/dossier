# Fact 43fda12f

Store id: 9dfe9300-16e9-47b3-b9c6-32ebb2b48d05

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
- posted_at: `2026-11-09T22:39:41.7167530+00:00`

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
  "id": "9dfe9300-16e9-47b3-b9c6-32ebb2b48d05",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7167530+00:00"
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
  "subject_id": "6e095c11-6d9c-4edb-aba5-288ff9da13bc",
  "subject_name": "django/db/models/expressions::Case.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
