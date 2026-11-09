# Fact fc322ff9

Store id: 366a9095-4f93-4ffa-b743-89c5a9466fc7

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
- posted_at: `2026-11-09T23:31:56.5933260+00:00`

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
  "id": "366a9095-4f93-4ffa-b743-89c5a9466fc7",
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
    "posted_at": "2026-11-09T23:31:56.5933260+00:00"
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
  "subject_id": "0c4631f9-b443-46ac-a8b4-e3dd933fbfea",
  "subject_name": "django/db/models/fields/__init__::DateTimeField._check_fix_default_value",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_fix_default_value(self)"
}
```
