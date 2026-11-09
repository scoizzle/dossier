# Fact d51bd653

Store id: 9a30c48f-5112-4a53-8752-564a4d3ac1c3

## Text

```text
def as_oracle(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:43.7367350+00:00`

## Data

```json
{
  "end_line": 663,
  "entity_kind": "method",
  "parent": "KeyTransformExact",
  "start_line": 651,
  "symbol": "KeyTransformExact.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":651,"selector":"L651-L663","symbol":"KeyTransformExact.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformExact.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 663,
    "entity_kind": "method",
    "parent": "KeyTransformExact",
    "start_line": 651,
    "symbol": "KeyTransformExact.as_oracle"
  },
  "id": "9a30c48f-5112-4a53-8752-564a4d3ac1c3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7367350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 651,
        "selector": "L651-L663",
        "symbol": "KeyTransformExact.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "5893310f-b2da-4eeb-a6a1-e0692dffe788",
  "subject_name": "django/db/models/fields/json::KeyTransformExact.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
