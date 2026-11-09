# Fact c3197f67

Store id: d5fa9bd6-dabf-4b72-bf5c-3eb38d0eb768

## Text

```text
def _check_unique_target(self)
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
- posted_at: `2026-11-09T23:31:58.6763380+00:00`

## Data

```json
{
  "end_line": 745,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 673,
  "symbol": "ForeignObject._check_unique_target"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":673,"selector":"L673-L745","symbol":"ForeignObject._check_unique_target"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject._check_unique_target](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 745,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 673,
    "symbol": "ForeignObject._check_unique_target"
  },
  "id": "d5fa9bd6-dabf-4b72-bf5c-3eb38d0eb768",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6763380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 673,
        "selector": "L673-L745",
        "symbol": "ForeignObject._check_unique_target"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "a97955df-6310-4f62-872b-cc794822fdf2",
  "subject_name": "django/db/models/fields/related::ForeignObject._check_unique_target",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_unique_target(self)"
}
```
