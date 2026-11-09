# Fact 987f980d

Store id: 2f1f7af6-794c-439f-94bf-f0322f75dcc2

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
- posted_at: `2026-11-09T23:44:53.5412830+00:00`

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
  "id": "2f1f7af6-794c-439f-94bf-f0322f75dcc2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.5412830+00:00"
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
  "subject_id": "09da5e0a-f4f3-4a44-a2e0-cbb03c467b60",
  "subject_name": "django/db/models/functions/json::JSONArray.as_native",
  "tags": [
    "entity:method"
  ],
  "text": "def as_native(self, compiler, connection, *, returning, **extra_context)"
}
```
