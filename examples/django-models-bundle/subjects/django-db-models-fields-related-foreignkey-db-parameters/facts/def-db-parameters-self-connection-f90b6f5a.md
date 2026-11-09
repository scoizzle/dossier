# Fact f90b6f5a

Store id: 7bf72c3a-53c6-4bcb-9887-9e8fae7e30d4

## Text

```text
def db_parameters(self, connection)
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
- posted_at: `2026-11-09T23:44:51.6072210+00:00`

## Data

```json
{
  "end_line": 1328,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1322,
  "symbol": "ForeignKey.db_parameters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1322,"selector":"L1322-L1328","symbol":"ForeignKey.db_parameters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.db_parameters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1328,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1322,
    "symbol": "ForeignKey.db_parameters"
  },
  "id": "7bf72c3a-53c6-4bcb-9887-9e8fae7e30d4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6072210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1322,
        "selector": "L1322-L1328",
        "symbol": "ForeignKey.db_parameters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "7cfa9c05-6ecd-41f4-b0b3-02a14678090a",
  "subject_name": "django/db/models/fields/related::ForeignKey.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
