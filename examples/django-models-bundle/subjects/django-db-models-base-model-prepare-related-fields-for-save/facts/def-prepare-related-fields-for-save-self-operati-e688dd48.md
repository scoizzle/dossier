# Fact e688dd48

Store id: 7d8a52ef-ed41-4dca-9eea-2ed91bf4e653

## Text

```text
def _prepare_related_fields_for_save(self, operation_name, fields=None)
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
- posted_at: `2026-11-09T22:39:40.3434880+00:00`

## Data

```json
{
  "end_line": 1322,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1270,
  "symbol": "Model._prepare_related_fields_for_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1270,"selector":"L1270-L1322","symbol":"Model._prepare_related_fields_for_save"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._prepare_related_fields_for_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1322,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1270,
    "symbol": "Model._prepare_related_fields_for_save"
  },
  "id": "7d8a52ef-ed41-4dca-9eea-2ed91bf4e653",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3434880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1270,
        "selector": "L1270-L1322",
        "symbol": "Model._prepare_related_fields_for_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "67205b71-d08f-445b-a568-5e78da5b04fd",
  "subject_name": "django/db/models/base::Model._prepare_related_fields_for_save",
  "tags": [
    "entity:method"
  ],
  "text": "def _prepare_related_fields_for_save(self, operation_name, fields=None)"
}
```
