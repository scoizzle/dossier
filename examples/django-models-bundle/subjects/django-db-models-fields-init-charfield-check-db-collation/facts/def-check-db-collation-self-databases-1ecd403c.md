# Fact 1ecd403c

Store id: dc87035a-d501-4091-89c5-9c194d0e4e6b

## Text

```text
def _check_db_collation(self, databases)
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
- posted_at: `2026-11-09T22:39:42.3784920+00:00`

## Data

```json
{
  "end_line": 1318,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1298,
  "symbol": "CharField._check_db_collation"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1298,"selector":"L1298-L1318","symbol":"CharField._check_db_collation"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField._check_db_collation](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1318,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1298,
    "symbol": "CharField._check_db_collation"
  },
  "id": "dc87035a-d501-4091-89c5-9c194d0e4e6b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3784920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1298,
        "selector": "L1298-L1318",
        "symbol": "CharField._check_db_collation"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "dfca6202-8185-4b99-93b9-03e73a25c4af",
  "subject_name": "django/db/models/fields/__init__::CharField._check_db_collation",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_db_collation(self, databases)"
}
```
