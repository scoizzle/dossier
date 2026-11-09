# Fact dc78f0b2

Store id: 3aeb0442-3d1e-4ff2-a0ad-752bde726d1c

## Text

```text
def _check_unique(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:58.8324300+00:00`

## Data

```json
{
  "end_line": 1556,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1547,
  "symbol": "ManyToManyField._check_unique"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1547,"selector":"L1547-L1556","symbol":"ManyToManyField._check_unique"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._check_unique](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1556,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1547,
    "symbol": "ManyToManyField._check_unique"
  },
  "id": "3aeb0442-3d1e-4ff2-a0ad-752bde726d1c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8324300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1547,
        "selector": "L1547-L1556",
        "symbol": "ManyToManyField._check_unique"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "01eec57c-1c87-44b6-a782-97844b416859",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_unique",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_unique(self, **kwargs)"
}
```
