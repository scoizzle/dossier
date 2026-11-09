# Fact e688dd48

Store id: b8da9d56-0e34-4a51-8b18-08fe6a4a72b9

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
- posted_at: `2026-11-09T23:31:53.7481930+00:00`

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
  "id": "b8da9d56-0e34-4a51-8b18-08fe6a4a72b9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7481930+00:00"
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
  "subject_id": "4aa244c1-dd9e-460c-b242-99f161931ea1",
  "subject_name": "django/db/models/base::Model._prepare_related_fields_for_save",
  "tags": [
    "entity:method"
  ],
  "text": "def _prepare_related_fields_for_save(self, operation_name, fields=None)"
}
```
