# Fact 40f96c97

Store id: 7f7ac2c8-6f24-4488-80be-ecff06d2f4ba

## Text

```text
class CompositePrimaryKey(Field)
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
- posted_at: `2026-11-09T22:39:42.9904210+00:00`

## Data

```json
{
  "end_line": 156,
  "entity_kind": "class",
  "parent": "composite",
  "start_line": 50,
  "symbol": "CompositePrimaryKey"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":50,"selector":"L50-L156","symbol":"CompositePrimaryKey"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 156,
    "entity_kind": "class",
    "parent": "composite",
    "start_line": 50,
    "symbol": "CompositePrimaryKey"
  },
  "id": "7f7ac2c8-6f24-4488-80be-ecff06d2f4ba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.9904210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 50,
        "selector": "L50-L156",
        "symbol": "CompositePrimaryKey"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "9f43eeac-0fd7-4e2e-8d73-98ad6396b36e",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey",
  "tags": [
    "entity:class"
  ],
  "text": "class CompositePrimaryKey(Field)"
}
```
