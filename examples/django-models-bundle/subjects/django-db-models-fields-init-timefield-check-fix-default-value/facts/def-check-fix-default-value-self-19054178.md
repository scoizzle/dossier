# Fact 19054178

Store id: 22d53e9d-50bf-4776-8015-b9ea846108c1

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
- posted_at: `2026-11-09T23:31:56.8147160+00:00`

## Data

```json
{
  "end_line": 2644,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2624,
  "symbol": "TimeField._check_fix_default_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2624,"selector":"L2624-L2644","symbol":"TimeField._check_fix_default_value"}`

## Items

```json
[
  {
    "text": "Warn that using an actual date or datetime value is probably wrong; it's only evaluated on server startup.",
    "locator": {
      "line": 2625
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField._check_fix_default_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2644,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2624,
    "symbol": "TimeField._check_fix_default_value"
  },
  "id": "22d53e9d-50bf-4776-8015-b9ea846108c1",
  "items": [
    {
      "locator": {
        "line": 2625
      },
      "text": "Warn that using an actual date or datetime value is probably wrong; it's only evaluated on server startup."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8147160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2624,
        "selector": "L2624-L2644",
        "symbol": "TimeField._check_fix_default_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "8f9c85b0-fed3-4e70-9204-45fe412a7d9f",
  "subject_name": "django/db/models/fields/__init__::TimeField._check_fix_default_value",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_fix_default_value(self)"
}
```
