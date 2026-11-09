# Fact 46b816ee

Store id: 07889c1a-582d-4e46-b002-754af44ade39

## Text

```text
def __len__(self)
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
- posted_at: `2026-11-09T22:39:49.3198490+00:00`

## Data

```json
{
  "end_line": 456,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 454,
  "symbol": "QuerySet.__len__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":454,"selector":"L454-L456","symbol":"QuerySet.__len__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__len__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 456,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 454,
    "symbol": "QuerySet.__len__"
  },
  "id": "07889c1a-582d-4e46-b002-754af44ade39",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3198490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 454,
        "selector": "L454-L456",
        "symbol": "QuerySet.__len__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "89f162dd-4d7b-4663-884c-afdb53f5435a",
  "subject_name": "django/db/models/query::QuerySet.__len__",
  "tags": [
    "entity:method"
  ],
  "text": "def __len__(self)"
}
```
