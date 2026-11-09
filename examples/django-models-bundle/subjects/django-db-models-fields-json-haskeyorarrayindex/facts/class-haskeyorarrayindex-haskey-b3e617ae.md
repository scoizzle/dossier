# Fact b3e617ae

Store id: 2c3e3435-3637-43c3-81b7-bd446a3b039c

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
- posted_at: `2026-11-09T23:44:50.9814710+00:00`

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
  "id": "2c3e3435-3637-43c3-81b7-bd446a3b039c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9814710+00:00"
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
  "subject_id": "100a079d-499f-4bff-af8a-f392c449888f",
  "subject_name": "django/db/models/fields/json::HasKeyOrArrayIndex",
  "tags": [
    "entity:class"
  ],
  "text": "class HasKeyOrArrayIndex(HasKey)"
}
```
