# Fact a5c536a8

Store id: 2f77d253-ac02-4c13-bf54-dd3676fc3dda

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
- posted_at: `2026-11-09T23:44:50.9361800+00:00`

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
  "id": "2f77d253-ac02-4c13-bf54-dd3676fc3dda",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9361800+00:00"
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
  "subject_id": "74952910-2484-416a-b7f0-d6516fb13351",
  "subject_name": "django/db/models/fields/json::JSONField._check_supported",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_supported(self, databases)"
}
```
