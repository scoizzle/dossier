# Fact 538e78ec

Store id: 8888dccd-bde1-443d-b206-72bc79aba58d

## Text

```text
def as_native(self, compiler, connection, *, returning, **extra_context)
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
- posted_at: `2026-11-09T23:32:01.5059710+00:00`

## Data

```json
{
  "end_line": 97,
  "entity_kind": "method",
  "parent": "JSONObject",
  "start_line": 90,
  "symbol": "JSONObject.as_native"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":90,"selector":"L90-L97","symbol":"JSONObject.as_native"}`

## Referenced by

None.

## Subject

[django/db/models/functions/json::JSONObject.as_native](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 97,
    "entity_kind": "method",
    "parent": "JSONObject",
    "start_line": 90,
    "symbol": "JSONObject.as_native"
  },
  "id": "8888dccd-bde1-443d-b206-72bc79aba58d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.5059710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 90,
        "selector": "L90-L97",
        "symbol": "JSONObject.as_native"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/json.py"
    }
  ],
  "status": "live",
  "subject_id": "7d593c19-0fad-40cf-b822-8d66fd149bcf",
  "subject_name": "django/db/models/functions/json::JSONObject.as_native",
  "tags": [
    "entity:method"
  ],
  "text": "def as_native(self, compiler, connection, *, returning, **extra_context)"
}
```
