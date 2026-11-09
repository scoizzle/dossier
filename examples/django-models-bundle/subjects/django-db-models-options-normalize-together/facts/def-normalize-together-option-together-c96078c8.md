# Fact c96078c8

Store id: 1978fd8a-0325-4218-9161-4383ea85aaf6

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
- posted_at: `2026-11-09T23:44:55.4399700+00:00`

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
  "id": "1978fd8a-0325-4218-9161-4383ea85aaf6",
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
    "posted_at": "2026-11-09T23:44:55.4399700+00:00"
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
  "subject_id": "f9f56be8-e526-45e8-82c9-de2e1b4327b9",
  "subject_name": "django/db/models/options::normalize_together",
  "tags": [
    "entity:function"
  ],
  "text": "def normalize_together(option_together)"
}
```
