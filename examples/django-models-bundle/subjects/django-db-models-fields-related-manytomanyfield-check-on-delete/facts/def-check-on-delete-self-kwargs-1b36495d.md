# Fact 1b36495d

Store id: 8dee3404-0c1f-4c07-bdac-9396dd55e33f

## Text

```text
def _check_on_delete(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.4625550+00:00`

## Data

```json
{
  "end_line": 1947,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1905,
  "symbol": "ManyToManyField._check_on_delete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1905,"selector":"L1905-L1947","symbol":"ManyToManyField._check_on_delete"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._check_on_delete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1947,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1905,
    "symbol": "ManyToManyField._check_on_delete"
  },
  "id": "8dee3404-0c1f-4c07-bdac-9396dd55e33f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4625550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1905,
        "selector": "L1905-L1947",
        "symbol": "ManyToManyField._check_on_delete"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "167f6ab7-b945-47ee-81f0-d4a121046abe",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_on_delete",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_on_delete(self, **kwargs)"
}
```
