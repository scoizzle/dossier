# Fact e688dd48

Store id: 8ee52f65-b84a-4429-97c0-3506f3407991

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
- posted_at: `2026-11-09T23:44:48.5369130+00:00`

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
  "id": "8ee52f65-b84a-4429-97c0-3506f3407991",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5369130+00:00"
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
  "subject_id": "db847c6c-2c85-4aa4-8f0b-e6436dfed268",
  "subject_name": "django/db/models/base::Model._prepare_related_fields_for_save",
  "tags": [
    "entity:method"
  ],
  "text": "def _prepare_related_fields_for_save(self, operation_name, fields=None)"
}
```
