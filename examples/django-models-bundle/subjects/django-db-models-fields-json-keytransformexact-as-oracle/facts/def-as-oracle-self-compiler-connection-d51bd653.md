# Fact d51bd653

Store id: 07bc334f-3026-40fa-8e73-88eadd952927

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
- posted_at: `2026-11-09T23:31:58.0031350+00:00`

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
  "id": "07bc334f-3026-40fa-8e73-88eadd952927",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0031350+00:00"
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
  "subject_id": "3f75713d-4a02-4f8d-91cc-fc01dc0c1ee1",
  "subject_name": "django/db/models/fields/json::KeyTransformExact.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
