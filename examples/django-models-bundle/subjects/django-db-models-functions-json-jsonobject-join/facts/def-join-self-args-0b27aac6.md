# Fact 0b27aac6

Store id: 8b1afccb-e4bb-4456-ab05-0dffd22b5fc8

## Text

```text
def join(self, args)
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
- posted_at: `2026-11-09T23:44:53.5564480+00:00`

## Data

```json
{
  "end_line": 88,
  "entity_kind": "method",
  "parent": "JSONObject",
  "start_line": 85,
  "symbol": "JSONObject.join"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":85,"selector":"L85-L88","symbol":"JSONObject.join"}`

## Referenced by

None.

## Subject

[django/db/models/functions/json::JSONObject.join](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 88,
    "entity_kind": "method",
    "parent": "JSONObject",
    "start_line": 85,
    "symbol": "JSONObject.join"
  },
  "id": "8b1afccb-e4bb-4456-ab05-0dffd22b5fc8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.5564480+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 85,
        "selector": "L85-L88",
        "symbol": "JSONObject.join"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/json.py"
    }
  ],
  "status": "live",
  "subject_id": "4ff4c399-afcc-4914-9b6e-8110ddea5731",
  "subject_name": "django/db/models/functions/json::JSONObject.join",
  "tags": [
    "entity:method"
  ],
  "text": "def join(self, args)"
}
```
