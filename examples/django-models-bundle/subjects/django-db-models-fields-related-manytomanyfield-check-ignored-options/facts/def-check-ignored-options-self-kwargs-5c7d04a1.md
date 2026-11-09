# Fact 5c7d04a1

Store id: ee7091d4-211a-4f93-9b2d-4cba635cf44c

## Text

```text
def _check_ignored_options(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.4516670+00:00`

## Data

```json
{
  "end_line": 1596,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1558,
  "symbol": "ManyToManyField._check_ignored_options"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1558,"selector":"L1558-L1596","symbol":"ManyToManyField._check_ignored_options"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._check_ignored_options](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1596,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1558,
    "symbol": "ManyToManyField._check_ignored_options"
  },
  "id": "ee7091d4-211a-4f93-9b2d-4cba635cf44c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4516670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1558,
        "selector": "L1558-L1596",
        "symbol": "ManyToManyField._check_ignored_options"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "f0668823-0d09-499e-9032-f7b45dd41fc1",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_ignored_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_ignored_options(self, **kwargs)"
}
```
