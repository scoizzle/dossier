# Fact 7fec7700

Store id: 888294c6-bd5a-493c-b340-2ce91ed391e5

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
- posted_at: `2026-11-09T22:39:46.3759090+00:00`

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
  "id": "888294c6-bd5a-493c-b340-2ce91ed391e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.3759090+00:00"
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
  "subject_id": "da979c81-4dcb-4e92-bd88-e7b650cf9c19",
  "subject_name": "django/db/models/functions/json::JSONArray.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
