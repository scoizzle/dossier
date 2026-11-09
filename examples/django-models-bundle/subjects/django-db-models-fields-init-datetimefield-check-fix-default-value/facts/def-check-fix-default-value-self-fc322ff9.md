# Fact fc322ff9

Store id: eb266c72-3b7b-4fd8-9bd5-6d12c6edde30

## Text

```text
def _check_fix_default_value(self)
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
- posted_at: `2026-11-09T23:44:50.1002470+00:00`

## Data

```json
{
  "end_line": 1632,
  "entity_kind": "method",
  "parent": "DateTimeField",
  "start_line": 1620,
  "symbol": "DateTimeField._check_fix_default_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1620,"selector":"L1620-L1632","symbol":"DateTimeField._check_fix_default_value"}`

## Items

```json
[
  {
    "text": "Warn that using an actual date or datetime value is probably wrong; it's only evaluated on server startup.",
    "locator": {
      "line": 1621
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeField._check_fix_default_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1632,
    "entity_kind": "method",
    "parent": "DateTimeField",
    "start_line": 1620,
    "symbol": "DateTimeField._check_fix_default_value"
  },
  "id": "eb266c72-3b7b-4fd8-9bd5-6d12c6edde30",
  "items": [
    {
      "locator": {
        "line": 1621
      },
      "text": "Warn that using an actual date or datetime value is probably wrong; it's only evaluated on server startup."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1002470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1620,
        "selector": "L1620-L1632",
        "symbol": "DateTimeField._check_fix_default_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "da753d42-15bc-4667-abcd-34687a2a937f",
  "subject_name": "django/db/models/fields/__init__::DateTimeField._check_fix_default_value",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_fix_default_value(self)"
}
```
