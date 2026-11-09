# Fact 4ecddcf9

Store id: 03f4ec17-a2b5-4656-85ad-2d229722cb5d

## Text

```text
def _clone(self)
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
- posted_at: `2026-11-09T23:44:56.2289050+00:00`

## Data

```json
{
  "end_line": 2483,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2471,
  "symbol": "RawQuerySet._clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2471,"selector":"L2471-L2483","symbol":"RawQuerySet._clone"}`

## Items

```json
[
  {
    "text": "Same as QuerySet._clone()",
    "locator": {
      "line": 2472
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet._clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2483,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2471,
    "symbol": "RawQuerySet._clone"
  },
  "id": "03f4ec17-a2b5-4656-85ad-2d229722cb5d",
  "items": [
    {
      "locator": {
        "line": 2472
      },
      "text": "Same as QuerySet._clone()"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2289050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2471,
        "selector": "L2471-L2483",
        "symbol": "RawQuerySet._clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1713f3df-9a6f-4130-ac5e-4f6a3c9c24b1",
  "subject_name": "django/db/models/query::RawQuerySet._clone",
  "tags": [
    "entity:method"
  ],
  "text": "def _clone(self)"
}
```
