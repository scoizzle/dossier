# Fact 1cc37b19

Store id: 53e00514-b04f-4088-ae8e-f0a789a10210

## Text

```text
class IntegerField(Field)
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
- posted_at: `2026-11-09T22:39:42.5285770+00:00`

## Data

```json
{
  "end_line": 2238,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2141,
  "symbol": "IntegerField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2141,"selector":"L2141-L2238","symbol":"IntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2238,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2141,
    "symbol": "IntegerField"
  },
  "id": "53e00514-b04f-4088-ae8e-f0a789a10210",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5285770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2141,
        "selector": "L2141-L2238",
        "symbol": "IntegerField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "5e061fe0-60a7-4714-a2cb-93881e9e2d7b",
  "subject_name": "django/db/models/fields/__init__::IntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class IntegerField(Field)"
}
```
