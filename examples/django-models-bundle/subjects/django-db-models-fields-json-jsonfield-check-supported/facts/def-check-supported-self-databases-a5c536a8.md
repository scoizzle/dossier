# Fact a5c536a8

Store id: e674b4f4-bd8d-4cc5-9431-56c708039da6

## Text

```text
def _check_supported(self, databases)
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
- posted_at: `2026-11-09T23:31:57.8367580+00:00`

## Data

```json
{
  "end_line": 76,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 54,
  "symbol": "JSONField._check_supported"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":54,"selector":"L54-L76","symbol":"JSONField._check_supported"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField._check_supported](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 76,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 54,
    "symbol": "JSONField._check_supported"
  },
  "id": "e674b4f4-bd8d-4cc5-9431-56c708039da6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8367580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 54,
        "selector": "L54-L76",
        "symbol": "JSONField._check_supported"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "bc44cca4-4626-4df0-8e22-592dbd08167c",
  "subject_name": "django/db/models/fields/json::JSONField._check_supported",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_supported(self, databases)"
}
```
