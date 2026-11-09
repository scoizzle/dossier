# Fact 12621cfc

Store id: 38a1d799-3cfe-434e-b0e9-bf9afda15388

## Text

```text
def __repr__(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:42.2686830+00:00`

## Data

```json
{
  "end_line": 297,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 291,
  "symbol": "Field.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":291,"selector":"L291-L297","symbol":"Field.__repr__"}`

## Items

```json
[
  {
    "text": "Display the module, class, and name of the field.",
    "locator": {
      "line": 292
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 297,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 291,
    "symbol": "Field.__repr__"
  },
  "id": "38a1d799-3cfe-434e-b0e9-bf9afda15388",
  "items": [
    {
      "locator": {
        "line": 292
      },
      "text": "Display the module, class, and name of the field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2686830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 291,
        "selector": "L291-L297",
        "symbol": "Field.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "379631f5-3bc5-418b-8e13-6d95c5c7b03e",
  "subject_name": "django/db/models/fields/__init__::Field.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
