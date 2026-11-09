# Fact 987f980d

Store id: 3f04d8de-a4d9-46ce-8e34-9db7bbbea88d

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
- posted_at: `2026-11-09T23:32:01.4654340+00:00`

## Data

```json
{
  "end_line": 33,
  "entity_kind": "method",
  "parent": "JSONArray",
  "start_line": 19,
  "symbol": "JSONArray.as_native"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":19,"selector":"L19-L33","symbol":"JSONArray.as_native"}`

## Referenced by

None.

## Subject

[django/db/models/functions/json::JSONArray.as_native](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 33,
    "entity_kind": "method",
    "parent": "JSONArray",
    "start_line": 19,
    "symbol": "JSONArray.as_native"
  },
  "id": "3f04d8de-a4d9-46ce-8e34-9db7bbbea88d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.4654340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 19,
        "selector": "L19-L33",
        "symbol": "JSONArray.as_native"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/json.py"
    }
  ],
  "status": "live",
  "subject_id": "40a270bb-07c1-4e6d-aa24-7a302c89164f",
  "subject_name": "django/db/models/functions/json::JSONArray.as_native",
  "tags": [
    "entity:method"
  ],
  "text": "def as_native(self, compiler, connection, *, returning, **extra_context)"
}
```
