# Fact 210340c1

Store id: c7548200-c6ab-4bee-b879-8f99d5a965ed

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
- posted_at: `2026-11-09T23:31:57.9071300+00:00`

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
  "id": "c7548200-c6ab-4bee-b879-8f99d5a965ed",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9071300+00:00"
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
  "subject_id": "d3912e20-8af3-4797-ba9f-04f04330edaf",
  "subject_name": "django/db/models/fields/json::HasAnyKeys",
  "tags": [
    "entity:class"
  ],
  "text": "class HasAnyKeys(HasKeys)"
}
```
