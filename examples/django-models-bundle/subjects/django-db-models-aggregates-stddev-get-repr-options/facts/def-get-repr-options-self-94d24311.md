# Fact 94d24311

Store id: b7d77d27-3310-4bec-8ea4-1e2f75fe0ae7

## Text

```text
def _get_repr_options(self)
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
- posted_at: `2026-11-09T22:39:40.0458970+00:00`

## Data

```json
{
  "end_line": 349,
  "entity_kind": "method",
  "parent": "StdDev",
  "start_line": 348,
  "symbol": "StdDev._get_repr_options"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":348,"selector":"L348-L349","symbol":"StdDev._get_repr_options"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StdDev._get_repr_options](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 349,
    "entity_kind": "method",
    "parent": "StdDev",
    "start_line": 348,
    "symbol": "StdDev._get_repr_options"
  },
  "id": "b7d77d27-3310-4bec-8ea4-1e2f75fe0ae7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0458970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 348,
        "selector": "L348-L349",
        "symbol": "StdDev._get_repr_options"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "ac2a46d2-982a-45c1-900a-cca81a6f2c7e",
  "subject_name": "django/db/models/aggregates::StdDev._get_repr_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_repr_options(self)"
}
```
