# Fact 210340c1

Store id: fa82cf74-09dc-4031-90fc-1b02bd96b08a

## Text

```text
class HasAnyKeys(HasKeys)
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
- posted_at: `2026-11-09T22:39:43.6603330+00:00`

## Data

```json
{
  "end_line": 286,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 283,
  "symbol": "HasAnyKeys"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":283,"selector":"L283-L286","symbol":"HasAnyKeys"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasAnyKeys](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 286,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 283,
    "symbol": "HasAnyKeys"
  },
  "id": "fa82cf74-09dc-4031-90fc-1b02bd96b08a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6603330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 283,
        "selector": "L283-L286",
        "symbol": "HasAnyKeys"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "9355a184-5006-4089-834c-4cc02f9f7112",
  "subject_name": "django/db/models/fields/json::HasAnyKeys",
  "tags": [
    "entity:class"
  ],
  "text": "class HasAnyKeys(HasKeys)"
}
```
