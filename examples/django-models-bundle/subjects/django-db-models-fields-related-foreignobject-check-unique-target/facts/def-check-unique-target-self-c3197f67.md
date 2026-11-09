# Fact c3197f67

Store id: 32821173-1f27-4edd-86f0-69c3d9c0a522

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
- posted_at: `2026-11-09T23:44:51.5225370+00:00`

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
  "id": "32821173-1f27-4edd-86f0-69c3d9c0a522",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5225370+00:00"
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
  "subject_id": "62b51a47-9193-4c8f-821a-42bb65ab2551",
  "subject_name": "django/db/models/fields/related::ForeignObject._check_unique_target",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_unique_target(self)"
}
```
