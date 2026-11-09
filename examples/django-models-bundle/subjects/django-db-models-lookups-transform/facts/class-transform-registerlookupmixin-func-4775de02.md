# Fact 4775de02

Store id: 79b87660-5a4e-4cb2-b558-fb802706fda8

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
- posted_at: `2026-11-09T23:32:03.1966990+00:00`

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
  "id": "79b87660-5a4e-4cb2-b558-fb802706fda8",
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
    "posted_at": "2026-11-09T23:32:03.1966990+00:00"
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
  "subject_id": "5185bf0d-262d-4ea4-a3e3-ce4a74effc8f",
  "subject_name": "django/db/models/lookups::Transform",
  "tags": [
    "entity:class"
  ],
  "text": "class Transform(RegisterLookupMixin, Func)"
}
```
