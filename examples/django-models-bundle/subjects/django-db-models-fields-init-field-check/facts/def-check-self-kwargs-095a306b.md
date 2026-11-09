# Fact 095a306b

Store id: 32e945e0-4026-4af2-b228-6e6f23ba1a9b

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:49.9691970+00:00`

## Data

```json
{
  "end_line": 310,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 299,
  "symbol": "Field.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":299,"selector":"L299-L310","symbol":"Field.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 310,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 299,
    "symbol": "Field.check"
  },
  "id": "32e945e0-4026-4af2-b228-6e6f23ba1a9b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9691970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 299,
        "selector": "L299-L310",
        "symbol": "Field.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1a5ce5d6-4c83-45b0-8138-d6f222302944",
  "subject_name": "django/db/models/fields/__init__::Field.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
