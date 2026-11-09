# Fact 5b33cb37

Store id: 0a65a8df-e062-479b-af0f-9f5ad0f80bf5

## Text

```text
class JSONIn(ProcessJSONLHSMixin, lookups.In)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:43.6947050+00:00`

## Data

```json
{
  "end_line": 483,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 403,
  "symbol": "JSONIn"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":403,"selector":"L403-L483","symbol":"JSONIn"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONIn](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 483,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 403,
    "symbol": "JSONIn"
  },
  "id": "0a65a8df-e062-479b-af0f-9f5ad0f80bf5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6947050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 403,
        "selector": "L403-L483",
        "symbol": "JSONIn"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "bff56f6e-310c-4ff6-8137-f7e44d63cd0a",
  "subject_name": "django/db/models/fields/json::JSONIn",
  "tags": [
    "entity:class"
  ],
  "text": "class JSONIn(ProcessJSONLHSMixin, lookups.In)"
}
```
