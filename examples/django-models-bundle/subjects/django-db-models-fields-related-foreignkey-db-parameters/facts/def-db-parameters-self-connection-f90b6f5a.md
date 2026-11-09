# Fact f90b6f5a

Store id: 4b72280c-1947-44de-b867-9ccec38f4649

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
- posted_at: `2026-11-09T23:31:58.7879470+00:00`

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
  "id": "4b72280c-1947-44de-b867-9ccec38f4649",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7879470+00:00"
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
  "subject_id": "dccaa7ca-ae8a-4ec0-b978-fc80cfd945dc",
  "subject_name": "django/db/models/fields/related::ForeignKey.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
