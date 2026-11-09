# Fact 0b373380

Store id: 1d509b7a-03ce-4545-8420-fd88a6cdf3bc

## Text

```text
def coalesce(self)
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
- posted_at: `2026-11-09T23:32:02.1735460+00:00`

## Data

```json
{
  "end_line": 122,
  "entity_kind": "method",
  "parent": "ConcatPair",
  "start_line": 112,
  "symbol": "ConcatPair.coalesce"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":112,"selector":"L112-L122","symbol":"ConcatPair.coalesce"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::ConcatPair.coalesce](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 122,
    "entity_kind": "method",
    "parent": "ConcatPair",
    "start_line": 112,
    "symbol": "ConcatPair.coalesce"
  },
  "id": "1d509b7a-03ce-4545-8420-fd88a6cdf3bc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1735460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 112,
        "selector": "L112-L122",
        "symbol": "ConcatPair.coalesce"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "ae146bb4-0ac6-4ebc-b063-567c85e2a89d",
  "subject_name": "django/db/models/functions/text::ConcatPair.coalesce",
  "tags": [
    "entity:method"
  ],
  "text": "def coalesce(self)"
}
```
