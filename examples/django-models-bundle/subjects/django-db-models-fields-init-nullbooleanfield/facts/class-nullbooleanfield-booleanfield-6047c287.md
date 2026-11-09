# Fact 6047c287

Store id: e4518f9b-38bf-4a90-acc7-49b9e367136a

## Text

```text
class NullBooleanField(BooleanField)
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
- posted_at: `2026-11-09T23:44:50.2035750+00:00`

## Data

```json
{
  "end_line": 2411,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2387,
  "symbol": "NullBooleanField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2387,"selector":"L2387-L2411","symbol":"NullBooleanField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::NullBooleanField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2411,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2387,
    "symbol": "NullBooleanField"
  },
  "id": "e4518f9b-38bf-4a90-acc7-49b9e367136a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2035750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2387,
        "selector": "L2387-L2411",
        "symbol": "NullBooleanField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "aba4f633-b292-4398-9c43-67fe6ba50197",
  "subject_name": "django/db/models/fields/__init__::NullBooleanField",
  "tags": [
    "entity:class"
  ],
  "text": "class NullBooleanField(BooleanField)"
}
```
