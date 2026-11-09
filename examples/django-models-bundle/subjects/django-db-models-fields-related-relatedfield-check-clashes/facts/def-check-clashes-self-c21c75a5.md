# Fact c21c75a5

Store id: 66f0cc7c-c9e3-4cf2-953c-43d0a5c832e9

## Text

```text
def _check_clashes(self)
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
- posted_at: `2026-11-09T23:44:51.4727530+00:00`

## Data

```json
{
  "end_line": 369,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 237,
  "symbol": "RelatedField._check_clashes"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":237,"selector":"L237-L369","symbol":"RelatedField._check_clashes"}`

## Items

```json
[
  {
    "text": "Check accessor and reverse query name clashes.",
    "locator": {
      "line": 238
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField._check_clashes](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 369,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 237,
    "symbol": "RelatedField._check_clashes"
  },
  "id": "66f0cc7c-c9e3-4cf2-953c-43d0a5c832e9",
  "items": [
    {
      "locator": {
        "line": 238
      },
      "text": "Check accessor and reverse query name clashes."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.4727530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 237,
        "selector": "L237-L369",
        "symbol": "RelatedField._check_clashes"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "ca054bbf-1f1d-4241-a241-206af3689d15",
  "subject_name": "django/db/models/fields/related::RelatedField._check_clashes",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_clashes(self)"
}
```
