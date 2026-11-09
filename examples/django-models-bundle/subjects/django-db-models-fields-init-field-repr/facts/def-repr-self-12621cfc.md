# Fact 12621cfc

Store id: 6651cb85-f343-4699-8d0c-cc68f2d95a0d

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
- posted_at: `2026-11-09T23:44:49.9680680+00:00`

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
  "id": "6651cb85-f343-4699-8d0c-cc68f2d95a0d",
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
    "posted_at": "2026-11-09T23:44:49.9680680+00:00"
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
  "subject_id": "becd3b51-5d1d-46ee-b0c6-9ae9a85468a8",
  "subject_name": "django/db/models/fields/__init__::Field.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
