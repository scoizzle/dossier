# Fact c7d89812

Store id: 9e79ceb2-88bc-4e36-a59f-efaac706d3af

## Text

```text
def _get_pk_val(self, meta=None)
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
- posted_at: `2026-11-09T22:39:40.3349500+00:00`

## Data

```json
{
  "end_line": 700,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 698,
  "symbol": "Model._get_pk_val"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":698,"selector":"L698-L700","symbol":"Model._get_pk_val"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._get_pk_val](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 700,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 698,
    "symbol": "Model._get_pk_val"
  },
  "id": "9e79ceb2-88bc-4e36-a59f-efaac706d3af",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3349500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 698,
        "selector": "L698-L700",
        "symbol": "Model._get_pk_val"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "81996a5a-3033-4752-8b28-b7fa24cbbfec",
  "subject_name": "django/db/models/base::Model._get_pk_val",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_pk_val(self, meta=None)"
}
```
