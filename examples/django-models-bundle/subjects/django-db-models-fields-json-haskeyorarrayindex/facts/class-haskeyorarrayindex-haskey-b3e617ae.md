# Fact b3e617ae

Store id: 447d8694-0ced-4fb0-b895-41e6211f3e2d

## Text

```text
class HasKeyOrArrayIndex(HasKey)
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
- posted_at: `2026-11-09T22:39:43.6623410+00:00`

## Data

```json
{
  "end_line": 291,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 289,
  "symbol": "HasKeyOrArrayIndex"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":289,"selector":"L289-L291","symbol":"HasKeyOrArrayIndex"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyOrArrayIndex](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 291,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 289,
    "symbol": "HasKeyOrArrayIndex"
  },
  "id": "447d8694-0ced-4fb0-b895-41e6211f3e2d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6623410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 289,
        "selector": "L289-L291",
        "symbol": "HasKeyOrArrayIndex"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "0128a03c-deef-4b74-89c5-1a95cd426793",
  "subject_name": "django/db/models/fields/json::HasKeyOrArrayIndex",
  "tags": [
    "entity:class"
  ],
  "text": "class HasKeyOrArrayIndex(HasKey)"
}
```
