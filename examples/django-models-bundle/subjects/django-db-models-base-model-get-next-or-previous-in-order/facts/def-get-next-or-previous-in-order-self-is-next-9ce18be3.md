# Fact 9ce18be3

Store id: 702c1dac-9921-46b8-a31e-085cd976452d

## Text

```text
def _get_next_or_previous_in_order(self, is_next)
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
- posted_at: `2026-11-09T22:39:40.3458650+00:00`

## Data

```json
{
  "end_line": 1395,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1374,
  "symbol": "Model._get_next_or_previous_in_order"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1374,"selector":"L1374-L1395","symbol":"Model._get_next_or_previous_in_order"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._get_next_or_previous_in_order](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1395,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1374,
    "symbol": "Model._get_next_or_previous_in_order"
  },
  "id": "702c1dac-9921-46b8-a31e-085cd976452d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3458650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1374,
        "selector": "L1374-L1395",
        "symbol": "Model._get_next_or_previous_in_order"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "35f56fb0-d513-4a7e-aadb-f5fdf39cf335",
  "subject_name": "django/db/models/base::Model._get_next_or_previous_in_order",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_next_or_previous_in_order(self, is_next)"
}
```
