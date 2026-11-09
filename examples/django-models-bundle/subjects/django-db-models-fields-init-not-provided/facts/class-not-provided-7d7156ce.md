# Fact 7d7156ce

Store id: 28f5a0f1-05fd-49d7-9f7f-25d37744b75c

## Text

```text
class NOT_PROVIDED
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
- posted_at: `2026-11-09T23:31:56.4057490+00:00`

## Data

```json
{
  "end_line": 85,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 84,
  "symbol": "NOT_PROVIDED"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":84,"selector":"L84-L85","symbol":"NOT_PROVIDED"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::NOT_PROVIDED](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 85,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 84,
    "symbol": "NOT_PROVIDED"
  },
  "id": "28f5a0f1-05fd-49d7-9f7f-25d37744b75c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4057490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 84,
        "selector": "L84-L85",
        "symbol": "NOT_PROVIDED"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "622e1b3a-064b-4cb7-bce9-5a354c2e3dda",
  "subject_name": "django/db/models/fields/__init__::NOT_PROVIDED",
  "tags": [
    "entity:class"
  ],
  "text": "class NOT_PROVIDED"
}
```
