# Fact b5266add

Store id: 36afb229-fa4b-426b-8c2f-490db8557286

## Text

```text
def attnames(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:42.9845190+00:00`

## Data

```json
{
  "end_line": 29,
  "entity_kind": "method",
  "parent": "CompositeAttribute",
  "start_line": 27,
  "symbol": "CompositeAttribute.attnames"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":27,"selector":"L27-L29","symbol":"CompositeAttribute.attnames"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositeAttribute.attnames](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 29,
    "entity_kind": "method",
    "parent": "CompositeAttribute",
    "start_line": 27,
    "symbol": "CompositeAttribute.attnames"
  },
  "id": "36afb229-fa4b-426b-8c2f-490db8557286",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.9845190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 27,
        "selector": "L27-L29",
        "symbol": "CompositeAttribute.attnames"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "9ea23eb5-3a09-471a-aa20-8eeb9e3b8102",
  "subject_name": "django/db/models/fields/composite::CompositeAttribute.attnames",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def attnames(self)"
}
```
