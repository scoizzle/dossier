# Fact 0b27aac6

Store id: 47da7004-8174-4c22-84be-4f9c68fbeea3

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
- posted_at: `2026-11-09T23:32:01.4919780+00:00`

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
  "id": "47da7004-8174-4c22-84be-4f9c68fbeea3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.4919780+00:00"
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
  "subject_id": "30c66d54-64ab-4367-a552-38fd1715e98e",
  "subject_name": "django/db/models/functions/json::JSONObject.join",
  "tags": [
    "entity:method"
  ],
  "text": "def join(self, args)"
}
```
