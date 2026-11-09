# Fact 4775de02

Store id: 1b0dee9e-d70d-48dd-81d5-e650b9aa3875

## Text

```text
class Transform(RegisterLookupMixin, Func)
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
- posted_at: `2026-11-09T22:39:48.0485330+00:00`

## Data

```json
{
  "end_line": 231,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 211,
  "symbol": "Transform"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":211,"selector":"L211-L231","symbol":"Transform"}`

## Items

```json
[
  {
    "text": "RegisterLookupMixin() is first so that get_lookup() and get_transform() first examine self and then check output_field.",
    "locator": {
      "line": 212
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/lookups::Transform](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 231,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 211,
    "symbol": "Transform"
  },
  "id": "1b0dee9e-d70d-48dd-81d5-e650b9aa3875",
  "items": [
    {
      "locator": {
        "line": 212
      },
      "text": "RegisterLookupMixin() is first so that get_lookup() and get_transform() first examine self and then check output_field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0485330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 211,
        "selector": "L211-L231",
        "symbol": "Transform"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "a63d1bea-ce2e-46b6-a4b0-ee3526c20fb2",
  "subject_name": "django/db/models/lookups::Transform",
  "tags": [
    "entity:class"
  ],
  "text": "class Transform(RegisterLookupMixin, Func)"
}
```
