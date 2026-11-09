# Fact 7fec7700

Store id: 3f9d58b4-5297-41d5-8c33-97a4fe954062

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:44:53.5455620+00:00`

## Data

```json
{
  "end_line": 65,
  "entity_kind": "method",
  "parent": "JSONArray",
  "start_line": 64,
  "symbol": "JSONArray.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":64,"selector":"L64-L65","symbol":"JSONArray.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/json::JSONArray.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 65,
    "entity_kind": "method",
    "parent": "JSONArray",
    "start_line": 64,
    "symbol": "JSONArray.as_oracle"
  },
  "id": "3f9d58b4-5297-41d5-8c33-97a4fe954062",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.5455620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 64,
        "selector": "L64-L65",
        "symbol": "JSONArray.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/json.py"
    }
  ],
  "status": "live",
  "subject_id": "7863bd87-6013-4414-90b3-00f88fe2950d",
  "subject_name": "django/db/models/functions/json::JSONArray.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
