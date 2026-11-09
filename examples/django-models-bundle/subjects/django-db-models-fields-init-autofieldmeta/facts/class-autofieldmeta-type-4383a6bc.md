# Fact 4383a6bc

Store id: a8089b3e-5b18-4bcf-90d5-79ac7b131945

## Text

```text
class AutoFieldMeta(type)
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
- posted_at: `2026-11-09T23:44:50.3279810+00:00`

## Data

```json
{
  "end_line": 2960,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2931,
  "symbol": "AutoFieldMeta"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2931,"selector":"L2931-L2960","symbol":"AutoFieldMeta"}`

## Items

```json
[
  {
    "text": "Metaclass to maintain backward inheritance compatibility for AutoField.",
    "locator": {
      "line": 2932
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMeta](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2960,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2931,
    "symbol": "AutoFieldMeta"
  },
  "id": "a8089b3e-5b18-4bcf-90d5-79ac7b131945",
  "items": [
    {
      "locator": {
        "line": 2932
      },
      "text": "Metaclass to maintain backward inheritance compatibility for AutoField."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3279810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2931,
        "selector": "L2931-L2960",
        "symbol": "AutoFieldMeta"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "ff67870e-8c9c-4e09-ad01-fe44d0af1b79",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMeta",
  "tags": [
    "entity:class"
  ],
  "text": "class AutoFieldMeta(type)"
}
```
