# Fact 044bcbb6

Store id: f636c906-3e6d-43b6-900e-72a3fa0748cd

## Text

```text
def _get_json_path(self, connection, key_transforms)
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
- posted_at: `2026-11-09T23:44:51.0030810+00:00`

## Data

```json
{
  "end_line": 361,
  "entity_kind": "method",
  "parent": "ProcessJSONLHSMixin",
  "start_line": 358,
  "symbol": "ProcessJSONLHSMixin._get_json_path"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":358,"selector":"L358-L361","symbol":"ProcessJSONLHSMixin._get_json_path"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::ProcessJSONLHSMixin._get_json_path](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 361,
    "entity_kind": "method",
    "parent": "ProcessJSONLHSMixin",
    "start_line": 358,
    "symbol": "ProcessJSONLHSMixin._get_json_path"
  },
  "id": "f636c906-3e6d-43b6-900e-72a3fa0748cd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0030810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 358,
        "selector": "L358-L361",
        "symbol": "ProcessJSONLHSMixin._get_json_path"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "2b62e879-f2e8-4b69-a3b3-447cfb43ab77",
  "subject_name": "django/db/models/fields/json::ProcessJSONLHSMixin._get_json_path",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_json_path(self, connection, key_transforms)"
}
```
