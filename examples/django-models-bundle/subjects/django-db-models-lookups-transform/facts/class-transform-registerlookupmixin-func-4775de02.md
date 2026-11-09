# Fact 4775de02

Store id: 12499ca7-1f8e-4400-8641-67d1db065bf4

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
- posted_at: `2026-11-09T23:44:54.9119820+00:00`

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
  "id": "12499ca7-1f8e-4400-8641-67d1db065bf4",
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
    "posted_at": "2026-11-09T23:44:54.9119820+00:00"
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
  "subject_id": "f5c5dd9a-eb8a-4e3f-bf7e-9fdb4e4b0609",
  "subject_name": "django/db/models/lookups::Transform",
  "tags": [
    "entity:class"
  ],
  "text": "class Transform(RegisterLookupMixin, Func)"
}
```
