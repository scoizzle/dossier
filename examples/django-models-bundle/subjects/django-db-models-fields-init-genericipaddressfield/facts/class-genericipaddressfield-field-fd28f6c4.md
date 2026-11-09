# Fact fd28f6c4

Store id: c7926800-4577-43a6-a905-77b032a70636

## Text

```text
class GenericIPAddressField(Field)
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
- posted_at: `2026-11-09T23:31:56.7304620+00:00`

## Data

```json
{
  "end_line": 2384,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2296,
  "symbol": "GenericIPAddressField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2296,"selector":"L2296-L2384","symbol":"GenericIPAddressField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::GenericIPAddressField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2384,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2296,
    "symbol": "GenericIPAddressField"
  },
  "id": "c7926800-4577-43a6-a905-77b032a70636",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7304620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2296,
        "selector": "L2296-L2384",
        "symbol": "GenericIPAddressField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "c62d5ba8-b30e-4da1-a118-b79a8ef4325e",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField",
  "tags": [
    "entity:class"
  ],
  "text": "class GenericIPAddressField(Field)"
}
```
