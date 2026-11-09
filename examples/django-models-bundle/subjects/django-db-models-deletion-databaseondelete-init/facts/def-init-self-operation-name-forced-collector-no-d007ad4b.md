# Fact d007ad4b

Store id: d2e095cf-2b6c-49ef-9cf6-5c72e6ba599a

## Text

```text
def __init__(self, operation, name, forced_collector=None)
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
- posted_at: `2026-11-09T23:31:55.0882710+00:00`

## Data

```json
{
  "end_line": 88,
  "entity_kind": "method",
  "parent": "DatabaseOnDelete",
  "start_line": 85,
  "symbol": "DatabaseOnDelete.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":85,"selector":"L85-L88","symbol":"DatabaseOnDelete.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::DatabaseOnDelete.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 88,
    "entity_kind": "method",
    "parent": "DatabaseOnDelete",
    "start_line": 85,
    "symbol": "DatabaseOnDelete.__init__"
  },
  "id": "d2e095cf-2b6c-49ef-9cf6-5c72e6ba599a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.0882710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 85,
        "selector": "L85-L88",
        "symbol": "DatabaseOnDelete.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "f6d28d9f-7e0b-4796-87e6-2249e062d295",
  "subject_name": "django/db/models/deletion::DatabaseOnDelete.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, operation, name, forced_collector=None)"
}
```
