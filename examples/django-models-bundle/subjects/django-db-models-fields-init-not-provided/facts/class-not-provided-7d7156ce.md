# Fact 7d7156ce

Store id: 20667ce6-1d83-4a9d-93a5-62e8e44c2dd6

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
- posted_at: `2026-11-09T22:39:42.2437210+00:00`

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
  "id": "20667ce6-1d83-4a9d-93a5-62e8e44c2dd6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2437210+00:00"
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
  "subject_id": "fc7c4826-9d1c-4178-b03a-ddaa3a5418fe",
  "subject_name": "django/db/models/fields/__init__::NOT_PROVIDED",
  "tags": [
    "entity:class"
  ],
  "text": "class NOT_PROVIDED"
}
```
