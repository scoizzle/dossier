# Fact 79f65729

Store id: dc94464b-e43d-4343-ac72-fd4bb26e6519

## Text

```text
def _subclasses(self)
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
- posted_at: `2026-11-09T22:39:42.7441770+00:00`

## Data

```json
{
  "end_line": 2950,
  "entity_kind": "method",
  "parent": "AutoFieldMeta",
  "start_line": 2948,
  "symbol": "AutoFieldMeta._subclasses"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2948,"selector":"L2948-L2950","symbol":"AutoFieldMeta._subclasses"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMeta._subclasses](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2950,
    "entity_kind": "method",
    "parent": "AutoFieldMeta",
    "start_line": 2948,
    "symbol": "AutoFieldMeta._subclasses"
  },
  "id": "dc94464b-e43d-4343-ac72-fd4bb26e6519",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7441770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2948,
        "selector": "L2948-L2950",
        "symbol": "AutoFieldMeta._subclasses"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "abdcfe2e-89f8-4809-b10e-adafe61491bc",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMeta._subclasses",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def _subclasses(self)"
}
```
