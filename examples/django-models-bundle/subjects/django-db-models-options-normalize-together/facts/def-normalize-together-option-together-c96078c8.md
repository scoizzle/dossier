# Fact c96078c8

Store id: 3515efc0-73b9-49f1-a30e-3d7830053f8a

## Text

```text
def normalize_together(option_together)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.7170590+00:00`

## Data

```json
{
  "end_line": 83,
  "entity_kind": "function",
  "parent": "options",
  "start_line": 64,
  "symbol": "normalize_together"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":64,"selector":"L64-L83","symbol":"normalize_together"}`

## Items

```json
[
  {
    "text": "option_together can be either a tuple of tuples, or a single tuple of two strings. Normalize it to a tuple of tuples, so that calling code can uniformly expect that.",
    "locator": {
      "line": 65
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::normalize_together](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 83,
    "entity_kind": "function",
    "parent": "options",
    "start_line": 64,
    "symbol": "normalize_together"
  },
  "id": "3515efc0-73b9-49f1-a30e-3d7830053f8a",
  "items": [
    {
      "locator": {
        "line": 65
      },
      "text": "option_together can be either a tuple of tuples, or a single tuple of two strings. Normalize it to a tuple of tuples, so that calling code can uniformly expect that."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.7170590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 64,
        "selector": "L64-L83",
        "symbol": "normalize_together"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "e8c0332e-80d1-46c4-9a36-04da90d6f831",
  "subject_name": "django/db/models/options::normalize_together",
  "tags": [
    "entity:function"
  ],
  "text": "def normalize_together(option_together)"
}
```
