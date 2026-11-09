# Fact 98ba845d

Store id: cc95c98a-7a49-46ee-baa2-b8474d03f097

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T22:39:51.0271870+00:00`

## Data

```json
{
  "end_line": 219,
  "entity_kind": "method",
  "parent": "BaseTable",
  "start_line": 216,
  "symbol": "BaseTable.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":216,"selector":"L216-L219","symbol":"BaseTable.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::BaseTable.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 219,
    "entity_kind": "method",
    "parent": "BaseTable",
    "start_line": 216,
    "symbol": "BaseTable.__eq__"
  },
  "id": "cc95c98a-7a49-46ee-baa2-b8474d03f097",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.0271870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 216,
        "selector": "L216-L219",
        "symbol": "BaseTable.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "b7cbbf40-f3e4-4afd-b988-20bd9b24063c",
  "subject_name": "django/db/models/sql/datastructures::BaseTable.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
