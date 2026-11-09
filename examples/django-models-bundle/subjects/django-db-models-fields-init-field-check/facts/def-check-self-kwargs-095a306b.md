# Fact 095a306b

Store id: f2eebc26-f9df-4033-a406-eb2121adce8f

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
- posted_at: `2026-11-09T23:31:56.4247160+00:00`

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
  "id": "f2eebc26-f9df-4033-a406-eb2121adce8f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4247160+00:00"
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
  "subject_id": "5a07eaf8-5a03-4a36-a2de-bca6e1b215df",
  "subject_name": "django/db/models/fields/__init__::Field.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
