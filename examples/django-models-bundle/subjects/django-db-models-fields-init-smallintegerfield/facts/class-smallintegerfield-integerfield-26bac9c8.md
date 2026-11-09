# Fact 26bac9c8

Store id: a87122d7-e3d6-4103-b77e-580442105a2a

## Text

```text
class SmallIntegerField(IntegerField)
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
- posted_at: `2026-11-09T22:39:42.5542560+00:00`

## Data

```json
{
  "end_line": 2262,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2258,
  "symbol": "SmallIntegerField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2258,"selector":"L2258-L2262","symbol":"SmallIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SmallIntegerField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2262,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2258,
    "symbol": "SmallIntegerField"
  },
  "id": "a87122d7-e3d6-4103-b77e-580442105a2a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5542560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2258,
        "selector": "L2258-L2262",
        "symbol": "SmallIntegerField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "60eb3a75-f1ad-49b3-a4b4-3c854be8cf94",
  "subject_name": "django/db/models/fields/__init__::SmallIntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class SmallIntegerField(IntegerField)"
}
```
